import { useEffect, useState } from "react";

// router
import { useParams } from "react-router-dom";

// services
import { getClinicById } from "../services/clinic";
import { getServicesClinic } from "../services/clinic";

export function useClinic() {
  const { id } = useParams();

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
      console.log(error);
    }
  };

  return { clinic, services };
}
