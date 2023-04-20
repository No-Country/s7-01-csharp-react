import axios from "axios";
import { BASE_URL } from "../const/backend";

export const veterinaryAproved = async (id) => {
  console.log(id, "axios");
  const baseUrl = `${BASE_URL}Autorizacion/veterinaria/${id}`;
  console.log(baseUrl);
  const res = await axios.get(baseUrl);
  return res.data;
};
