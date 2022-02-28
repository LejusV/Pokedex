using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Pyroar Specie to store common natural stats of all Pyroars
	#region SpeciePyroar
	public class SpeciePyroar : PokemonSpecie
	{
#nullable enable
		private static SpeciePyroar? _instance = null;
#nullable restore
        public static SpeciePyroar Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciePyroar();
                }
                return _instance;
            }
        }

		#region SpeciePyroar Builder
		public SpeciePyroar() : base(
			"Pyroar",
			86, // HPs
			68, 72, // Attack & Defense
			109, 66, // Special Attack & Defense
			106			
		) {}
		#endregion
	}
	#endregion

	//Pyroar Pokemon Class
	#region Pyroar
	public class Pyroar : Pokemon
	{
		#region Pyroar Builders
		/// <summary>
		/// Pyroar Builder waiting for a Nickname & a Level
		/// </summary>
		public Pyroar(string nickname, int level)
		: base(
				668,
				SpeciePyroar.Instance, // Pokemon Specie
				nickname, level,
				Fire.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pyroar Builder only waiting for a Level
		/// </summary>
		public Pyroar(int level)
		: base(
				668,
				SpeciePyroar.Instance, // Pokemon Specie
				"Pyroar", level,
				Fire.Instance, Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Pyroar Builder waiting for no params (Building a Wiki Pokemon without personal stats nor any level)
		/// </summary>
		public Pyroar() : base(
			668,
			SpeciePyroar.Instance, // Pokemon Specie
			Fire.Instance, Normal.Instance			
		) {}
		#endregion
	}
	#endregion
}