import axios from "axios";
import { BASE_URL } from "../const/backend";

export const getAllServices = async()=> {   
 const ruta = `${BASE_URL}servicios`  
 const respuesta = await axios.get(ruta)
 return respuesta.data
}

