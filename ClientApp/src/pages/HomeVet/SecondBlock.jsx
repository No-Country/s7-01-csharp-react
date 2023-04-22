import React from 'react'
import imgPerro from "../../assets/images/imgPerro.png";
<<<<<<< HEAD
import imgPerro2 from "../../assets/images/imgPerro2.png";
import imgPerro3 from "../../assets/images/imgPerro3.png";
import { Link } from 'react-router-dom';

const SecondBlock = () => {
=======
import { Link } from 'react-router-dom';

const SecondBlock = ({mascotas}) => {
    if(!mascotas) 
    {return(<div className="container mx-auto ">
            <div className="mt-8 p-2 bg-gray-50">
                <h3 className="ml-2 text-[18px] font-bold">No hay mascotas asociadas</h3>
            </div>
        </div>)}
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
    return (
        <div className="container mx-auto ">
            <div className="mt-8 p-2 bg-gray-50">
                <h3 className="ml-2 text-[18px] font-bold">Mis Pacientes(3)</h3>
            </div>
<<<<<<< HEAD
            <div className="mt-6 flex w-full justify-around">             

                <Link to={`/app/petInfo`}>
                    <div className="">
                        <img
                            src={imgPerro}
                            alt="perro"
                            className="h-16 w-16 rounded-full hover:scale-110 hover:duration-500 hover:transition-all cursor-pointer"
                        />
                        <p className="text-center">{"Mascota"}</p>
                    </div>
                </Link>
                <div className="">
                    <img
                        src={imgPerro2}
                        alt="perro"
                        className="h-16 w-16 rounded-full hover:scale-110 hover:duration-500 hover:transition-all cursor-pointer"
                    />
                    <p className="text-center">{"Mascota"}</p>
                </div>
                <div className="">
                    <img
                        src={imgPerro3}
                        alt="perro"
                        className="h-16 w-16 rounded-full hover:scale-110 hover:duration-500 hover:transition-all cursor-pointer"
                    />
                    <p className="text-center">{"Mascota"}</p>
                </div>
            </div>
=======
            
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
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
            <div />
        </div>
    )
}

export default SecondBlock