import { useEffect, useState } from "react";

// router
import { useParams } from "react-router-dom";

// services
import { getClinicById } from "../services/clinic";

export function useClinic() {
  const { id } = useParams();

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
      console.log(error);
    }
  };

  return { clinic };
}
