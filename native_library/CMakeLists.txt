cmake_minimum_required(VERSION 3.8.2)

PROJECT(native_library)

#set(CMAKE_WINDOWS_EXPORT_ALL_SYMBOLS ON)

set(SRC_COMMON_OBJECTS
	${CMAKE_CURRENT_SOURCE_DIR}/include/native.h
    ${CMAKE_CURRENT_SOURCE_DIR}/src/native.cpp
)

add_library(native_library SHARED ${SRC_COMMON_OBJECTS})

target_include_directories(native_library PRIVATE ${CMAKE_CURRENT_SOURCE_DIR}/include)

set_target_properties( native_library PROPERTIES RUNTIME_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin )
set_target_properties( native_library PROPERTIES RUNTIME_OUTPUT_DIRECTORY_DEBUG ${CMAKE_BINARY_DIR}/bin )
set_target_properties( native_library PROPERTIES RUNTIME_OUTPUT_DIRECTORY_RELEASE ${CMAKE_BINARY_DIR}/bin )

set_target_properties( native_library PROPERTIES LIBRARY_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin )
set_target_properties( native_library PROPERTIES LIBRARY_OUTPUT_DIRECTORY_DEBUG ${CMAKE_BINARY_DIR}/bin )
set_target_properties( native_library PROPERTIES LIBRARY_OUTPUT_DIRECTORY_RELEASE ${CMAKE_BINARY_DIR}/bin )

set_target_properties( native_library PROPERTIES ARCHIVE_OUTPUT_DIRECTORY ${CMAKE_BINARY_DIR}/bin )
set_target_properties( native_library PROPERTIES ARCHIVE_OUTPUT_DIRECTORY_DEBUG ${CMAKE_BINARY_DIR}/bin )
set_target_properties( native_library PROPERTIES ARCHIVE_OUTPUT_DIRECTORY_RELEASE ${CMAKE_BINARY_DIR}/bin )
