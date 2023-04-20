import axios from "axios";
import { BASE_URL } from "../const/backend";

export const getAllPropietaries = async()=> {   
 const ruta = `${BASE_URL}Propietario`  
 const respuesta = await axios.get(ruta)
 return respuesta.data
}