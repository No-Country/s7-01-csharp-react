import axios from "axios";
import { BASE_URL } from "../const/backend";

<<<<<<< HEAD
export const getAllUsers = async()=> {   
 const ruta = `${BASE_URL}Mascota/getForPropietarie/1`  
 const respuesta = await axios.get(ruta)
 return respuesta.data
}

=======
export const getAllUsers = async () => {
  const ruta = `${BASE_URL}Mascota/getForPropietarie/1`;
  const respuesta = await axios.get(ruta);
  return respuesta.data;
};
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
