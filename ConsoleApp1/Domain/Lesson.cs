namespace ConsoleApp1.Domain;

public class Lesson(int id, DateTime moment, int maxCapacity)
{
    public int Id { get; set; } = id;

    public DateTime Moment { get; set; } = moment;

    public int MaxCapacity { get; set; } = maxCapacity;

    private List<Member> _members  = [];

    public IEnumerable<Member> Members => _members;
    
    public void AddMember(Member member)
    {
        ArgumentNullException.ThrowIfNull(member, nameof(member));

        if (_members.All(m => m.Name != member.Name))
        {
            _members.Add(member);
            
        }
        
    }
    
    
}