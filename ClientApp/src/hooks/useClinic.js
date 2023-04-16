import { useEffect, useState } from "react";

// services
import { getClinicById, getServicesClinic } from "../services/clinic";

export function useClinic() {
  const [hola, setHola] = useState(true);
  const [services, setServices] = useState({});

  useEffect(() => {
    console.log("consultando");
    getClinic();
  }, []);

  const getClinic = async () => {
    try {
      const response = await getClinicById(2);
      console.log(response);
      const idVet = response.result.id;
      const res = await getServicesClinic(idVet);
      setServices(res);
      console.log(idVet);
    } catch (error) {
      console.log(error);
    }
  };

  return { hola, services };
}
