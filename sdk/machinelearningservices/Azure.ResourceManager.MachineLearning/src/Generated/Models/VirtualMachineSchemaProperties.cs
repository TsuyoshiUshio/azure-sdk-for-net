// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.MachineLearning.Models
{
    /// <summary> The VirtualMachineSchemaProperties. </summary>
    public partial class VirtualMachineSchemaProperties
    {
        /// <summary> Initializes a new instance of VirtualMachineSchemaProperties. </summary>
        public VirtualMachineSchemaProperties()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineSchemaProperties. </summary>
        /// <param name="virtualMachineSize"> Virtual Machine size. </param>
        /// <param name="sshPort"> Port open for ssh connections. </param>
        /// <param name="notebookServerPort"> Notebook server port open for ssh connections. </param>
        /// <param name="address"> Public IP address of the virtual machine. </param>
        /// <param name="administratorAccount"> Admin credentials for virtual machine. </param>
        /// <param name="isNotebookInstanceCompute"> Indicates whether this compute will be used for running notebooks. </param>
        internal VirtualMachineSchemaProperties(string virtualMachineSize, int? sshPort, int? notebookServerPort, string address, VirtualMachineSshCredentials administratorAccount, bool? isNotebookInstanceCompute)
        {
            VirtualMachineSize = virtualMachineSize;
            SshPort = sshPort;
            NotebookServerPort = notebookServerPort;
            Address = address;
            AdministratorAccount = administratorAccount;
            IsNotebookInstanceCompute = isNotebookInstanceCompute;
        }

        /// <summary> Virtual Machine size. </summary>
        public string VirtualMachineSize { get; set; }
        /// <summary> Port open for ssh connections. </summary>
        public int? SshPort { get; set; }
        /// <summary> Notebook server port open for ssh connections. </summary>
        public int? NotebookServerPort { get; set; }
        /// <summary> Public IP address of the virtual machine. </summary>
        public string Address { get; set; }
        /// <summary> Admin credentials for virtual machine. </summary>
        public VirtualMachineSshCredentials AdministratorAccount { get; set; }
        /// <summary> Indicates whether this compute will be used for running notebooks. </summary>
        public bool? IsNotebookInstanceCompute { get; set; }
    }
}
