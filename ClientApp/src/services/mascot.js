import axios from "axios";
import { BASE_URL } from "../const/backend";

export const getMascotByUser = async (id) => {
  console.log(id, "axios");
  const baseUrl = `${BASE_URL}Mascota/getForPropietarie/${id}`;
  // console.log(baseUrl);
  const res = await axios.get(baseUrl);
  return res.data;
};
