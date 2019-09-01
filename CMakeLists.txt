cmake_minimum_required(VERSION 3.8.2)

PROJECT(Interop)

# Output the version to the Version.h file.
configure_file (
  "${CMAKE_CURRENT_SOURCE_DIR}/net_proj/net_proj.csproj"
  "${CMAKE_CURRENT_BINARY_DIR}/net_proj/net_proj.csproj"
)

configure_file (
  "${CMAKE_CURRENT_SOURCE_DIR}/Directory.build.props"
  "${CMAKE_CURRENT_BINARY_DIR}/Directory.build.props"
)

if (MSVC)
  include_external_msproject(InteropTest ${CMAKE_CURRENT_BINARY_DIR}/net_proj/net_proj.csproj)
else ()
  configure_file (
    "${CMAKE_CURRENT_SOURCE_DIR}/net_core.sln"
    "${CMAKE_CURRENT_BINARY_DIR}/net_core.sln"
  )
endif ()

add_subdirectory(native_library)