using Composite.BaseExample;

BaseExample();

static void BaseExample()
{
    Client client = new();

    Leaf leaf = new();

    Console.WriteLine("Client: I get a simple component");

    client.ClientCode(leaf);

    Composite.BaseExample.Composite tree = new();
    Composite.BaseExample.Composite branch1 = new();

    branch1.Add(new Leaf());
    branch1.Add(new Leaf());

    Composite.BaseExample.Composite branch2 = new();
    branch2.Add(new Leaf());

    tree.Add(branch1);
    tree.Add(branch2);

    Console.WriteLine("Client: Now I've got a composite tree:");
    client.ClientCode(tree);

    Console.WriteLine("Client: I don't need to check the components classes even when managing the tree:\n");
    client.ClientCode2(tree, leaf);
}