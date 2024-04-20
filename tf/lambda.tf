resource "aws_lambda_function" "function" {
  function_name = local.service_name
  role          = aws_iam_role.lambdaRole.arn

  memory_size = 128
  timeout = 120
  
  architectures = ["x86_64"]

  package_type = "Image"
  image_uri = data.aws_ecr_image.image.image_uri
}