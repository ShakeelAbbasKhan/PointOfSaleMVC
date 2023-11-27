using PointOfSaleMVC.Data;

namespace PointOfSaleMVC.Repository
{
    public class ImageRepository 
    {
      
        //public ImageRepository(ApplicationDbContext _dbContext)
        //{
        //    dbContext = _dbContext;
        //}
        //private readonly ApplicationDbContext dbContext;

        //public Assignments CreateAssignment(Assignments assignment)
        //{
        //    if (assignment == null)
        //    {
        //        throw new ArgumentNullException(nameof(assignment));
        //    }

        //    dbContext.Add(assignment);
        //    dbContext.SaveChanges();
        //    return assignment;
        //}


        //public void SaveFilePaths(List<FilePath> filePathlist)
        //{
        //    if (filePathlist == null)
        //    {
        //        throw new ArgumentNullException(nameof(filePathlist));
        //    }

        //    dbContext.AddRange(filePathlist);
        //    dbContext.SaveChanges();
        //}

        //public List<Assignments> GetAllAssignments()
        //{
        //    return dbContext.Assignments.ToList();
        //}

        //public List<FilePath> GetFilesbyAssignmentId(int id)
        //{
        //    var filepaths = dbContext.FilePaths.Include(u => u.Assignment).Where(x => x.AssignmentId == id).ToList();
        //    return filepaths;
        //}
    }
}
