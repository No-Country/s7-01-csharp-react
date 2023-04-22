import axios from "axios";
import { BASE_URL } from "../const/backend";

export const addMascotaVeterinary = async (idVet, idPet) => {
  const baseUrl = `${BASE_URL}Autorizacion`;
  console.log(baseUrl);
  const res = await axios.post(baseUrl, {
    mascotaId: idPet,
    veterinariaId: idVet,
  });
  return res;
};
