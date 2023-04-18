import axios from "axios";
import { BASE_URL } from "../const/backend";

export const getRememberCard = async()=> {   
 const ruta = `${BASE_URL}Recordatorios/1`  
 const respuesta = await axios.get(ruta)
 return respuesta.data
}
