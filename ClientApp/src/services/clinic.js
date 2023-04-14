import axios from "axios";
import { BASE_URL } from "../const/backend";

export const getClinicById = async (id) => {
  console.log(id, "axios");
  // const baseUrl = `${BASE_URL}Veterinaria/${id}`;
  const baseUrl = "http://mimascota.somee.com/api/Veterinaria/1";

  console.log(baseUrl);
  const res = await axios.get(baseUrl);
  return res.data;
};
