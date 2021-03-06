/**
 * Copyright (c) 2001-2018 Mathew A. Nelson and Robocode contributors
 * All rights reserved. This program and the accompanying materials
 * are made available under the terms of the Eclipse Public License v1.0
 * which accompanies this distribution, and is available at
 * http://robocode.sourceforge.net/license/epl-v10.html
 */
using Robocode;

namespace net.sf.robocode.security
{
#pragma warning disable 1591
    /// <exclude/>
    public interface IHiddenBulletHelper
    {
        void update(Bullet bullet, double x, double y, string victimName, bool isActive);
    }
}

//happy