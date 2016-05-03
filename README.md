# SME - Synchronous Message Exchange

Synchronous Message Exchange is a programming model for developing systems that respond to a shared synchronization signal. Any SME system can be expressed as a CSP network, but SME is more limited, so not all CSP systems can be expressed in SME.

The limitations in SME makes it more suitable for developing hardware models, and enables faster execution that what can be obtained with CSP.

This library is a re-implementation of the Python implementation described in these articles:
  * [BPU Simulator](http://www.wotug.org/papers/CPA-2013/Rehr13/Rehr13.pdf)
  * [Synchronous Message Exchange for Hardware Designs](http://wotug.org/cpa2014/preprints/12-preprint.pdf)
  * [Bus Centric Synchronous Message Exchange for Hardware Designs](https://www.researchgate.net/profile/Kenneth_Skovhede/publication/281278995_Bus_Centric_Synchronous_Message_Exchange_for_Hardware_Designs/links/55deccc808ae45e825d3a681.pdf)

The library is used as a means for simulating and experimenting with designing a vector processor, named the [Bohrium Processing Unit](https://github.com/kenkendk/bpu), capable of running [Bohrium](http://bh107.org) vector byte-code on FPGA hardware.

The packages [SME](https://www.nuget.org/packages/SME/), [SME.GraphViz](https://www.nuget.org/packages/SME.GraphViZ/), and [SME.VHDL](https://www.nuget.org/packages/SME.VHDL/) are all available through [NuGet](https://www.nuget.org).


