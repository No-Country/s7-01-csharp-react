import React from "react";
import { Routes, Route } from "react-router-dom";

// components
import Home from "../pages/Home";
import { Clinic } from "../pages/Clinic";
import { AddPet } from "../pages/AddPet";
import PetInfo from "../pages/PetInfo/PetInfo";
import HomeVet from "../pages/HomeVet/HomeVet";
import PetVet from "../pages/PetVet/PetVet";

export function AppRouter() {
  return (
    <>
      <Routes>
        <Route path="/home" element={<Home />} />
        <Route path="/clinic" element={<Clinic />} />
        <Route path="/petinfo" element={<PetInfo />} />
        <Route path="/add-mascot" element={<AddPet />} />
        <Route path="/veterinary" element={<HomeVet/>} />
        <Route path="/propvet" element={<PetVet/>} />
      </Routes>
    </>
  );
}
