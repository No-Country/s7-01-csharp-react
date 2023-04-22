import React from 'react'
import imgPerro from "../../assets/images/imgPerro.png";
import { Link } from 'react-router-dom';

const SecondBlock = ({mascotas}) => {
    if(!mascotas) 
    {return(<div className="container mx-auto ">
            <div className="mt-8 p-2 bg-gray-50">
                <h3 className="ml-2 text-[18px] font-bold">No hay mascotas asociadas</h3>
            </div>
        </div>)}
    return (
        <div className="container mx-auto ">
            <div className="mt-8 p-2 bg-gray-50">
                <h3 className="ml-2 text-[18px] font-bold">Mis Pacientes(3)</h3>
            </div>
            
            {mascotas.length > 0 && (

            
            <div className="mt-6 flex w-full justify-around">             

               {mascotas.map(m =>(
                 <Link key={m.id} to={`/app/petInfoVet/${m.mascotaId}`}>
                    <div className="">
                        <img
                            src={m.mascota.urlFotoPerfil}
                            alt="perro"
                            className="h-16 w-16 rounded-full hover:scale-110 hover:duration-500 hover:transition-all cursor-pointer"
                        />
                        <p className="text-center">{m.mascota.nombre}</p>
                    </div>
                </Link>
               ))}
                
            </div>
            )}
            <div />
        </div>
    )
}

export default SecondBlock