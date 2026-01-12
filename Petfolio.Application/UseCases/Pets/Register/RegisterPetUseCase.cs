using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.Register;

public class RegisterPetUseCase
{
    public ResponseRegisteredPetJson Execute(ResponseRegisteredPetJson request) {
        return new ResponseRegisteredPetJson
        {
            Id = 7,
            Name = request.Name
        };
    }

    public object Execute(RequestRegisterPetJson request)
    {
        throw new NotImplementedException();
    }
}
