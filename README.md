Pulsing-Control
===============

`PulseControl` is a pulsing animation CALayer for `UIView`. 

![demo](images/sample.gif)

## Requirements

- iOS 8.1+

## Installation

### NuGet

`PulseControl` is available through [Nuget](http://nuget.org). To install
use next command or Nuget manager:

```
Install-Package Xamarin.iOS.PulseControl
```

### Manual

Simply copy the folder `Xam.iOS.PulseControl` to your project and reference to the `PulseControl.csproj`.

## Usage

### Getting Started

##### Via code

```csharp
using Xamarin.iOS.PulseControl
```

Create a `PulseControl` object, and add it via 'myView.Layer.AddSubLayer()'. Code below insert three 'Pulse' layer to provide animation as on the sample image.

```csharp
const float radius = 80;
RootView.Layer.InsertSublayer(new PulseCALayer(radius, RootView.Center) { BackgroundColor = UIColor.Red.CGColor }, 0);
RootView.Layer.InsertSublayer(new PulseCALayer(radius, RootView.Center, delay: 0.2f) { BackgroundColor = UIColor.Red.CGColor }, 1);
RootView.Layer.InsertSublayer(new PulseCALayer(radius, RootView.Center, delay: 0.4f) { BackgroundColor = UIColor.Red.CGColor }, 1);
```

### Properties

`PulseControl` has a few customizable constructor parameters:

* `radius` (should be positive)
The radius of the pulse.

* `animationDuration` (default is 1.5)
The duration of the animation

* `delay` (default is 0.01)
The time time before the animation starts

* `nextPulseAfter` (default is 0)
the time interval between the start of ripple

* `initialPulseScale` (default is 0)
The initial scale of the pulse

* `numberOfPulses` (default is 'float.PositiveInfinity')
The number of pulses

## License

`PulseControl` is released under the MIT license.
