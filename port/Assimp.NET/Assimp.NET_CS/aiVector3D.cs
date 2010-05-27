/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 1.3.40
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


using System;
using System.Runtime.InteropServices;

public class aiVector3D : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal aiVector3D(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(aiVector3D obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~aiVector3D() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          Assimp_NETPINVOKE.delete_aiVector3D(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public aiVector3D() : this(Assimp_NETPINVOKE.new_aiVector3D__SWIG_0(), true) {
  }

  public aiVector3D(float _x, float _y, float _z) : this(Assimp_NETPINVOKE.new_aiVector3D__SWIG_1(_x, _y, _z), true) {
  }

  public aiVector3D(float _xyz) : this(Assimp_NETPINVOKE.new_aiVector3D__SWIG_2(_xyz), true) {
  }

  public aiVector3D(aiVector3D o) : this(Assimp_NETPINVOKE.new_aiVector3D__SWIG_3(aiVector3D.getCPtr(o)), true) {
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
  }

  public aiVector3D __addnset__(aiVector3D o) {
    aiVector3D ret = new aiVector3D(Assimp_NETPINVOKE.aiVector3D___addnset__(swigCPtr, aiVector3D.getCPtr(o)), false);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiVector3D __subnset__(aiVector3D o) {
    aiVector3D ret = new aiVector3D(Assimp_NETPINVOKE.aiVector3D___subnset__(swigCPtr, aiVector3D.getCPtr(o)), false);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiVector3D __mulnset__(float f) {
    aiVector3D ret = new aiVector3D(Assimp_NETPINVOKE.aiVector3D___mulnset____SWIG_0(swigCPtr, f), false);
    return ret;
  }

  public aiVector3D __divnset__(float f) {
    aiVector3D ret = new aiVector3D(Assimp_NETPINVOKE.aiVector3D___divnset__(swigCPtr, f), false);
    return ret;
  }

  public aiVector3D __mulnset__(aiMatrix3x3 mat) {
    aiVector3D ret = new aiVector3D(Assimp_NETPINVOKE.aiVector3D___mulnset____SWIG_1(swigCPtr, aiMatrix3x3.getCPtr(mat)), false);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public aiVector3D __mulnset__(aiMatrix4x4 mat) {
    aiVector3D ret = new aiVector3D(Assimp_NETPINVOKE.aiVector3D___mulnset____SWIG_2(swigCPtr, aiMatrix4x4.getCPtr(mat)), false);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float __idx__(uint i) {
    float ret = Assimp_NETPINVOKE.aiVector3D___idx____SWIG_0(swigCPtr, i);
    return ret;
  }

  public bool __equal__(aiVector3D other) {
    bool ret = Assimp_NETPINVOKE.aiVector3D___equal__(swigCPtr, aiVector3D.getCPtr(other));
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool __nequal__(aiVector3D other) {
    bool ret = Assimp_NETPINVOKE.aiVector3D___nequal__(swigCPtr, aiVector3D.getCPtr(other));
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void Set(float pX, float pY, float pZ) {
    Assimp_NETPINVOKE.aiVector3D_Set(swigCPtr, pX, pY, pZ);
  }

  public float SquareLength() {
    float ret = Assimp_NETPINVOKE.aiVector3D_SquareLength(swigCPtr);
    return ret;
  }

  public float Length() {
    float ret = Assimp_NETPINVOKE.aiVector3D_Length(swigCPtr);
    return ret;
  }

  public aiVector3D Normalize() {
    aiVector3D ret = new aiVector3D(Assimp_NETPINVOKE.aiVector3D_Normalize(swigCPtr), false);
    return ret;
  }

  public aiVector3D SymMul(aiVector3D o) {
    aiVector3D ret = new aiVector3D(Assimp_NETPINVOKE.aiVector3D_SymMul(swigCPtr, aiVector3D.getCPtr(o)), true);
    if (Assimp_NETPINVOKE.SWIGPendingException.Pending) throw Assimp_NETPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public float x {
    set {
      Assimp_NETPINVOKE.aiVector3D_x_set(swigCPtr, value);
    } 
    get {
      float ret = Assimp_NETPINVOKE.aiVector3D_x_get(swigCPtr);
      return ret;
    } 
  }

  public float y {
    set {
      Assimp_NETPINVOKE.aiVector3D_y_set(swigCPtr, value);
    } 
    get {
      float ret = Assimp_NETPINVOKE.aiVector3D_y_get(swigCPtr);
      return ret;
    } 
  }

  public float z {
    set {
      Assimp_NETPINVOKE.aiVector3D_z_set(swigCPtr, value);
    } 
    get {
      float ret = Assimp_NETPINVOKE.aiVector3D_z_get(swigCPtr);
      return ret;
    } 
  }

}