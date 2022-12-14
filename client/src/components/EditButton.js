import React from "react";
import FormEditMeeting from "./FormEditMeeting";

const Modal = (props) => {
  const [showModal, setShowModal] = React.useState(false);

  const CloseModal = () => setShowModal(false);

  return (
    <>
      <button className="bg-white hover:bg-gray-100 text-gray-800 font-semibold py-2 px-4 border border-gray-400 rounded shadow" type="button" onClick={() => setShowModal(true)}>Edit</button>
      {showModal ? (
        <>
          <div
            className="justify-center items-center flex overflow-x-hidden overflow-y-auto fixed inset-0 z-50 outline-none focus:outline-none"
          >
            <div className="relative w-auto my-6 mx-auto max-w-3xl">
              <div className="border-0 rounded-lg shadow-lg relative flex flex-col w-full bg-white outline-none focus:outline-none">
                <div className="flex items-start justify-between p-5 border-b border-solid border-slate-200 rounded-t">
                  <h3 className="text-3xl font-semibold">
                    Edit Event
                  </h3>
                </div>
                <div className="relative p-6 flex-auto">
                  <div className="my-4 text-slate-500 text-lg leading-relaxed">
                    <FormEditMeeting id={props.id} date={props.date} description={props.description} location={props.location} language={props.language} creatorEmail={props.creatorEmail} />
                  </div>
                </div>
                <div className="flex items-center justify-end p-6 border-t border-solid border-slate-200 rounded-b">
                  <button
                    className="text-red-500 background-transparent font-bold uppercase px-6 py-2 text-sm outline-none focus:outline-none mr-1 mb-1 ease-linear transition-all duration-150"
                    type="button"
                    onClick={CloseModal}
                  >
                    Close
                  </button>
                </div>
              </div>
            </div>
          </div>
          <div className="opacity-25 fixed inset-0 z-40 bg-black"></div>
        </>
      ) : null}
    </>
  );
}

export default Modal;
