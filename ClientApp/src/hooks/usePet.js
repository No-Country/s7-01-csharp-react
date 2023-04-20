import { useEffect, useState } from "react";

// router
import { useParams } from "react-router-dom";

// services
import { getPetyId } from "../services/pet";
import { getHistoryPet } from "../services/history";

export function usePet() {
  const { id } = useParams();

  const [pet, setPet] = useState({});
  const [tratamientos, setTratamientos] = useState([]);
  const [vacunas, setVacunas] = useState([]);

  useEffect(() => {
    console.log("consultando pet");
    getPet(id);
  }, [id]);

  const getPet = async (id) => {
    try {
      const response = await getPetyId(id);
      const pet = response.result;
      const res = await getHistoryPet(5);
      setTratamientos(res.tratamientos);
      setVacunas(res.vacunas);
      setPet(pet);
    } catch (error) {
      console.log(error);
    }
  };

  return { pet, tratamientos, vacunas };
}
