using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Torracat Species to store common natural stats of all Torracats
	#region SpeciesTorracat
	public class SpeciesTorracat : PokemonSpecies
	{
#nullable enable
		private static SpeciesTorracat? _instance = null;
#nullable restore
        public static SpeciesTorracat Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTorracat();
                }
                return _instance;
            }
        }

		#region SpeciesTorracat Constructor
		public SpeciesTorracat() : base(
			"Torracat",
			0.7,
			25.0,
			65, // HPs
			85, 50, // Attack & Defense
			80, 50, // Special Attack & Defense
			90		
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
				"Scratch",
				"Swords-Dance",
				"Double-Kick",
				"Thrash",
				"Leer",
				"Bite",
				"Growl",
				"Roar",
				"Ember",
				"Flamethrower",
				"Toxic",
				"Double-Team",
				"Lick",
				"Fire-Blast",
				"Leech-Life",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Sunny-Day",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Overheat",
				"Bulk-Up",
				"U-Turn",
				"Flare-Blitz",
				"Shadow-Claw",
				"Fire-Fang",
				"Flame-Charge",
				"Round",
				"Acrobatics",
				"Fire-Pledge",
				"Work-Up",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Torracat PokemonInstance Class
	#region Torracat
	public class TorracatInstance : PokemonInstance
	{
		#region Torracat Constructors
		/// <summary>
		/// Torracat Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TorracatInstance(string nickname, int level)
		: base(
				726,
				SpeciesTorracat.Instance, // Pokemon Species
				nickname, level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torracat Builder only waiting for a Level
		/// </summary>
		public TorracatInstance(int level)
		: base(
				726,
				SpeciesTorracat.Instance, // PokemonInstance Species
				"Torracat", level,
				Fire.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Torracat Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Torracat() : base(
			726,
			SpeciesTorracat.Instance, // PokemonInstance Species
			Fire.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}