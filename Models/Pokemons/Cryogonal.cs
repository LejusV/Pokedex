using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Cryogonal Species to store common natural stats of all Cryogonals
	#region SpeciesCryogonal
	public class SpeciesCryogonal : PokemonSpecies
	{
#nullable enable
		private static SpeciesCryogonal? _instance = null;
#nullable restore
        public static SpeciesCryogonal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesCryogonal();
                }
                return _instance;
            }
        }

		#region SpeciesCryogonal Constructor
		public SpeciesCryogonal() : base(
			"Cryogonal",
			1.1,
			148.0,
			80, // HPs
			50, 50, // Attack & Defense
			95, 135, // Special Attack & Defense
			105		
		)
		{
			InitMovesList();
		}
		#endregion

		#region Methods
		private void InitMovesList()
		{
			_moveList = new List<string>()
			{
				"Bind",
				"Mist",
				"Ice-Beam",
				"Blizzard",
				"Aurora-Beam",
				"Hyper-Beam",
				"Solar-Beam",
				"Toxic",
				"Double-Team",
				"Recover",
				"Confuse-Ray",
				"Light-Screen",
				"Haze",
				"Reflect",
				"Acid-Armor",
				"Explosion",
				"Rest",
				"Sharpen",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Rapid-Spin",
				"Hidden-Power",
				"Rain-Dance",
				"Ancient-Power",
				"Hail",
				"Facade",
				"Magic-Coat",
				"Knock-Off",
				"Secret-Power",
				"Signal-Beam",
				"Sheer-Cold",
				"Iron-Defense",
				"Water-Pulse",
				"Poison-Jab",
				"Night-Slash",
				"Ice-Shard",
				"Flash-Cannon",
				"Round",
				"Acrobatics",
				"Frost-Breath",
				"Freeze-Dry",
				"Confide",
				"Aurora-Veil"
			};
		}
		#endregion
	}
	#endregion

	//Cryogonal PokemonInstance Class
	#region Cryogonal
	public class CryogonalInstance : PokemonInstance
	{
		#region Cryogonal Constructors
		/// <summary>
		/// Cryogonal Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public CryogonalInstance(string nickname, int level)
		: base(
				615,
				SpeciesCryogonal.Instance, // Pokemon Species
				nickname, level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cryogonal Builder only waiting for a Level
		/// </summary>
		public CryogonalInstance(int level)
		: base(
				615,
				SpeciesCryogonal.Instance, // PokemonInstance Species
				"Cryogonal", level,
				Ice.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Cryogonal Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Cryogonal() : base(
			615,
			SpeciesCryogonal.Instance, // PokemonInstance Species
			Ice.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}