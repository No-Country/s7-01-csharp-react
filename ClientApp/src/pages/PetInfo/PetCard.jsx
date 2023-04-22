import React from "react";
<<<<<<< HEAD
import imgPerro from "../../assets/images/imgPerro.png"

const PetCard = () => {
  return (
    <>
      <div className="mt-4 w-[328px] h-[275px] ml-4 ">
        <img src={imgPerro} alt="perro" className="mt-6" />
        <p className="mt-4 ml-4 text-gray-150">{"{Raza}"}</p>
        <p className="mt-2 text-[24px]">
          {"{nombre de la"} <br />
          {"mascota}"}
        </p>
        <p className="mt-2 text-gray-150">
          {"{Sexo}"}°{"{Edad}"}°{"{Peso}"}
        </p>
      </div>
    </>
=======
import imgPerro from "../../assets/images/imgPerro.png";

const PetCard = ({ pet }) => {
  // console.log("🚀 ~ file: PetCard.jsx:5 ~ PetCard ~ pet:", pet);

  return (
    <div className="flex flex-row justify-start items-center gap-6 p-6 mt-4 w-10/12  ml-4 bg-white">
      <img
        src={pet.urlFotoPerfil}
        alt="perro"
        className="mt-6 rounded-full object-cover object-center"
      />
      <div>
        <p className="mt-2 text-gray-150">{pet.especie}</p>
        <p className="mt-2 text-[24px]">{pet.nombre}</p>
        <p className="mt-2 text-gray-150">
          {pet.sexo} - {pet.peso}kg
        </p>
      </div>
    </div>
>>>>>>> aca0c765fa2d510625ef751a8ad51e40cb2bbc00
  );
};

export default PetCard;
