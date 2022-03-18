using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Togepi Species to store common natural stats of all Togepis
	#region SpeciesTogepi
	public class SpeciesTogepi : PokemonSpecies
	{
#nullable enable
		private static SpeciesTogepi? _instance = null;
#nullable restore
        public static SpeciesTogepi Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesTogepi();
                }
                return _instance;
            }
        }

		#region SpeciesTogepi Constructor
		public SpeciesTogepi() : base(
			175,
			"Togepi",
			0.3,
			1.5,
			35, // HPs
			20, 65, // Attack & Defense
			40, 65, // Special Attack & Defense
			20		
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
				"Mega-Punch",
				"Mega-Kick",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Growl",
				"Flamethrower",
				"Peck",
				"Counter",
				"Seismic-Toss",
				"Solar-Beam",
				"Thunder-Wave",
				"Toxic",
				"Psychic",
				"Mimic",
				"Double-Team",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Metronome",
				"Mirror-Move",
				"Fire-Blast",
				"Swift",
				"Soft-Boiled",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Curse",
				"Protect",
				"Sweet-Kiss",
				"Mud-Slap",
				"Zap-Cannon",
				"Foresight",
				"Detect",
				"Endure",
				"Charm",
				"Rollout",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Present",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Encore",
				"Morning-Sun",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Follow-Me",
				"Trick",
				"Wish",
				"Magic-Coat",
				"Yawn",
				"Endeavor",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Extrasensory",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"Fling",
				"Psycho-Shift",
				"Lucky-Chant",
				"Last-Resort",
				"Nasty-Plot",
				"Zen-Headbutt",
				"Captivate",
				"Grass-Knot",
				"Psyshock",
				"Telekinesis",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Incinerate",
				"Bestow",
				"Work-Up",
				"Confide",
				"Dazzling-Gleam"
			};
		}
		#endregion
	}
	#endregion

	//Togepi PokemonInstance Class
	#region Togepi
	public class TogepiInstance : PokemonInstance
	{
		#region Togepi Constructors
		/// <summary>
		/// Togepi Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public TogepiInstance(string nickname, int level)
		: base(
				SpeciesTogepi.Instance, // Pokemon Species
				nickname, level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togepi Builder only waiting for a Level
		/// </summary>
		public TogepiInstance(int level)
		: base(
				SpeciesTogepi.Instance, // PokemonInstance Species
				"Togepi", level,
				Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Togepi Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public TogepiInstance() : base(
			SpeciesTogepi.Instance, // PokemonInstance Species
			Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}