using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Xerneas Species to store common natural stats of all Xerneass
	#region SpeciesXerneas
	public class SpeciesXerneas : PokemonSpecies
	{
#nullable enable
		private static SpeciesXerneas? _instance = null;
#nullable restore
        public static SpeciesXerneas Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesXerneas();
                }
                return _instance;
            }
        }

		#region SpeciesXerneas Constructor
		public SpeciesXerneas() : base(
			"Xerneas",
			3.0,
			215.0,
			126, // HPs
			131, 95, // Attack & Defense
			131, 98, // Special Attack & Defense
			99		
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
				"Cut",
				"Take-Down",
				"Roar",
				"Aurora-Beam",
				"Hyper-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Outrage",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Megahorn",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Hail",
				"Facade",
				"Nature-Power",
				"Ingrain",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Aromatherapy",
				"Block",
				"Calm-Mind",
				"Gravity",
				"Close-Combat",
				"Night-Slash",
				"Focus-Blast",
				"Giga-Impact",
				"Zen-Headbutt",
				"Flash-Cannon",
				"Grass-Knot",
				"Wonder-Room",
				"Psyshock",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
				"Horn-Leech",
				"Misty-Terrain",
				"Moonblast",
				"Confide",
				"Geomancy",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Xerneas PokemonInstance Class
	#region Xerneas
	public class XerneasInstance : PokemonInstance
	{
		#region Xerneas Constructors
		/// <summary>
		/// Xerneas Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public XerneasInstance(string nickname, int level)
		: base(
				716,
				SpeciesXerneas.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xerneas Builder only waiting for a Level
		/// </summary>
		public XerneasInstance(int level)
		: base(
				716,
				SpeciesXerneas.Instance, // PokemonInstance Species
				"Xerneas", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Xerneas Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Xerneas() : base(
			716,
			SpeciesXerneas.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}