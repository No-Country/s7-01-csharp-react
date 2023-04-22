import axios from "axios";
import { BASE_URL } from "../const/backend";

export const getTratamiento = async (id) => {
  console.log(id, "axios");
  const baseUrl = `${BASE_URL}Tratamiento/gettratamientobyveterinariaId/${id}`;
  // console.log(baseUrl);
  const res = await axios.get(baseUrl);
  return res.data.result;
};
