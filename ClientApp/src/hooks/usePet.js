import { useEffect, useState } from "react";

// router
import { useParams } from "react-router-dom";

// services
import { getPetyId } from "../services/pet";

export function usePet() {
  const { id } = useParams();

  const [pet, setPet] = useState({});

  useEffect(() => {
    console.log("consultando pet");
    getPet(id);
  }, []);

  const getPet = async (id) => {
    try {
      const response = await getPetyId(id);
      // console.log("🚀 ~ file: usePet.js:22 ~ getPet ~ response:", response);
      const pet = response.result;
      setPet(pet);
    } catch (error) {
      console.log(error);
    }
  };

  return { pet };
}
