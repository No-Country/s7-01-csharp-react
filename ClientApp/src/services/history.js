import axios from "axios";
import { BASE_URL } from "../const/backend";

export const getHistoryPet = async (id) => {
  console.log(id, "axios history");
  const baseUrl = `${BASE_URL}HistoriaClinica/historiaclinica/mascota/${id}`;

  console.log(baseUrl);
  const res = await axios.get(baseUrl);
  return res.data;
};
