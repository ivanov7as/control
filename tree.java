import java.util.List;

public interface Tree {

    public List<Tree> getParent();

    public List<Tree> getChildren();

    public void setParent(Tree parent);

    public void addChildren(Tree children);
}
