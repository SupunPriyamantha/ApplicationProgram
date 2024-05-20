namespace ApplicationProgram.Api.Models
{
    public abstract class BaseResponse
    {
        [System.Text.Json.Serialization.JsonIgnore]
        public int StatusCode { get; set; }
    }
}
