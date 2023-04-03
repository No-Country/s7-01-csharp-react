import { CoverClinic } from "../../components/CoverClinic";
import { DataClinic } from "../../components/DataClinic";
import { ContactClinic } from "../../components/ContactClinic";
import { InfoClinic } from "../../components/InfoClinic";
import Navbar from "../../components/Layouts/Navbar";

export function Clinic() {
  return (
    <>
      <Navbar />
      <CoverClinic />
      <main className="flex flex-col gap-8">
        <DataClinic />
        <ContactClinic />
        <InfoClinic />
      </main>
    </>
  );
}
