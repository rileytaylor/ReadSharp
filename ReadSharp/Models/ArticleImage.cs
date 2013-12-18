﻿using PropertyChanged;
using System;

namespace ReadSharp
{
  /// <summary>
  /// Article image
  /// </summary>
  [ImplementPropertyChanged]
  public class ArticleImage
  {
    /// <summary>
    /// Gets or sets the URI.
    /// </summary>
    /// <value>
    /// The URI.
    /// </value>
    public Uri Uri { get; set; }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    /// <value>
    /// The title.
    /// </value>
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets the alternative text.
    /// </summary>
    /// <value>
    /// The alternative text.
    /// </value>
    public string AlternativeText { get; set; }
  }
}
