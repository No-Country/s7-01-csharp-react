import axios from "axios";
import { BASE_URL } from "../const/backend";

export const getPetyId = async (id) => {
  console.log(id, "axios pet");
  const baseUrl = `${BASE_URL}Mascota/getMascota/${id}`;

  console.log(baseUrl);
  const res = await axios.get(baseUrl);
  return res.data;
};
