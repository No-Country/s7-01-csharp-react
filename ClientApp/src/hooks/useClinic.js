import { useEffect, useState } from "react";

// services
import { getClinicById } from "../services/clinic";

export function useClinic() {
  const [hola, setHola] = useState(true);

  useEffect(() => {
    console.log("consultando");
    getClinic();
  }, []);

  const getClinic = async () => {
    try {
      const response = await getClinicById(1);
      console.log(response);
    } catch (error) {
      console.log(error);
    }
  };

  return { hola };
}
