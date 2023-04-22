<<<<<<< HEAD
import React from "react";
=======
import React, { useEffect, useState } from "react";
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
import { PawPrint } from "@phosphor-icons/react";
import imgPerro from "../../assets/images/imgPerro.png";
import imgPerro2 from "../../assets/images/imgPerro2.png";
import imgPerro3 from "../../assets/images/imgPerro3.png";

// Rutas
import { Link } from "react-router-dom";

<<<<<<< HEAD
const ShowPets = () => {
  return (
    <div className="container mx-auto">
      <div className="mt-4 p-2 bg-gray-50">
        <h3 className="ml-2 text-[18px] font-bold">Mis Mascotas(5)</h3>
=======
// redux
import { useSelector } from "react-redux";

// services
import { getMascotByUser } from "../../services/mascot";

const ShowPets = () => {
  const idUser = useSelector((state) => state.userId);
  const [mascots, setMascots] = useState([]);

  useEffect(() => {
    getmascot(idUser && idUser);
  }, []);

  const getmascot = async (id) => {
    try {
      // console.log(id);
      // console.log("cargando mascota");
      const response = await getMascotByUser(id);
      console.log(
        "🚀 ~ file: ShowPets.jsx:27 ~ getmascot ~ response:",
        response.result
      );

      setMascots(response.result);
    } catch (error) {
      console.log(error);
    }
  };

  // console.log(mascots);

  return (
    <div className="container mx-auto">
      <div className="mt-4 p-2 bg-gray-50">
        <h3 className="ml-2 text-[18px] font-bold">
          Mis Mascotas({mascots.length})
        </h3>
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
      </div>
      <div className="mt-6 flex w-full justify-around">
        <Link to={`/app/add-mascot`}>
          <div className="relative">
<<<<<<< HEAD
            <div className="h-16 w-16 rounded-full border bg-gray-100 hover:border-purple-700">
              <PawPrint size={28} className="absolute left-4 top-4" />
=======
            <div className="h-16 w-16 md:h-20 md:w-20 rounded-full border bg-gray-100 hover:border-purple-700 flex justify-center items-center">
              <PawPrint size={36} />
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
            </div>
            <p className="text-center">Agregar</p>
            <p className="text-center">Mascota</p>
          </div>
        </Link>
<<<<<<< HEAD

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
=======
        {mascots.map((mascot) => (
          <Link key={mascot.id} to={`/app/petInfo/${mascot.id}`}>
            <div className="">
              <img
                src={mascot.urlFotoPerfil}
                alt="perro"
                className="h-16 w-16 md:h-20 md:w-20 rounded-full hover:scale-110 hover:duration-500 hover:transition-all cursor-pointer"
              />
              <p className="text-center">{mascot.nombre}</p>
            </div>
          </Link>
        ))}

        {/* <div className="">
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
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
<<<<<<< HEAD
        </div>
=======
        </div> */}
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
      </div>
      <div />
    </div>
  );
};

export default ShowPets;
