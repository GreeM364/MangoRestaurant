using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class UpdateSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://mango364.blob.core.windows.net/product/11.jpg?sp=r&st=2024-05-16T10:41:58Z&se=2024-05-16T18:41:58Z&sv=2022-11-02&sr=b&sig=alAlrFymwlrgiQM15N1NOVfObKMfB%2FG4chxHi%2BrvJuc%3D");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://mango364.blob.core.windows.net/product/12.jpg?sp=r&st=2024-05-16T10:42:23Z&se=2024-05-16T18:42:23Z&sv=2022-11-02&sr=b&sig=oZXSbiovX9I%2BQU3qYDqYUrhAu4QCUrCKenTxCRXc4GA%3D");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://mango364.blob.core.windows.net/product/13.jpg?sp=r&st=2024-05-16T10:42:53Z&se=2024-05-16T18:42:53Z&sv=2022-11-02&sr=b&sig=6pUwPNLLwMbnhtLWwzR8xe152gBVwImFHAAsa5rOKUs%3D");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://mango364.blob.core.windows.net/product/14.jpg?sp=r&st=2024-05-16T10:43:20Z&se=2024-05-16T18:43:20Z&sv=2022-11-02&sr=b&sig=wjXVVpuZZrvx2MpiPt4%2F43Ul%2FcCRKTRo7cCvOqT7ccE%3D");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "ImageUrl",
                value: "https://mango364.blob.core.windows.net/product/11.jpg?sv=2022-11-02&ss=b&srt=o&sp=r&se=2024-01-31T04:19:09Z&st=2023-12-25T20:19:09Z&spr=https&sig=Ru9gUDGKisZTdtJ2SEx6CKoWZn92%2F3A%2BQrIH%2FwMr58E%3D");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "ImageUrl",
                value: "https://mango364.blob.core.windows.net/product/12.jpg?sv=2022-11-02&ss=b&srt=o&sp=r&se=2024-01-31T04:19:09Z&st=2023-12-25T20:19:09Z&spr=https&sig=Ru9gUDGKisZTdtJ2SEx6CKoWZn92%2F3A%2BQrIH%2FwMr58E%3D");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "ImageUrl",
                value: "https://mango364.blob.core.windows.net/product/13.jpg?sv=2022-11-02&ss=b&srt=o&sp=r&se=2024-01-31T04:19:09Z&st=2023-12-25T20:19:09Z&spr=https&sig=Ru9gUDGKisZTdtJ2SEx6CKoWZn92%2F3A%2BQrIH%2FwMr58E%3D");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4,
                column: "ImageUrl",
                value: "https://mango364.blob.core.windows.net/product/14.jpg?sv=2022-11-02&ss=b&srt=o&sp=r&se=2024-01-31T04:19:09Z&st=2023-12-25T20:19:09Z&spr=https&sig=Ru9gUDGKisZTdtJ2SEx6CKoWZn92%2F3A%2BQrIH%2FwMr58E%3D");
        }
    }
}
