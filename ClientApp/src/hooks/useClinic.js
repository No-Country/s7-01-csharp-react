import { useEffect, useState } from "react";

// router
import { useParams } from "react-router-dom";

// services
import { getClinicById } from "../services/clinic";
<<<<<<< HEAD
=======
import { getServicesClinic } from "../services/clinic";
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00

export function useClinic() {
  const { id } = useParams();

<<<<<<< HEAD
  const [hola, setHola] = useState(true);
  // const [services, setServices] = useState({});
  const [clinic, setClinic] = useState({});

  useEffect(() => {
    console.log("consultando");
    getClinic();
  }, []);

  const getClinic = async () => {
    try {
      const response = await getClinicById(id);
      const vet = response.result;
      setClinic(vet);
      // const res = await getServicesClinic(idVet);
      // setServices(res);
    } catch (error) {
      console.log("🚀 ~ file: useClinic.js:29 ~ getClinic ~ error:", error);
=======
  const [clinic, setClinic] = useState({});
  const [services, setServices] = useState([]);

  useEffect(() => {
    // console.log("consultando");
    getClinic(id);
  }, []);

  const getClinic = async (id) => {
    try {
      const response = await getClinicById(id);
      const vet = response.result;
      const res = await getServicesClinic(vet.id);
      const serv = res.result;
      setClinic(vet);
      setServices(serv);
    } catch (error) {
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
      console.log(error);
    }
  };

<<<<<<< HEAD
  return { clinic };
=======
  return { clinic, services };
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
}
