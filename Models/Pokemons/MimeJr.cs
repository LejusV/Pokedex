using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Mime-Jr Species to store common natural stats of all Mime-Jrs
	#region SpeciesMime-Jr
	public class SpeciesMimeJr : PokemonSpecies
	{
#nullable enable
		private static SpeciesMimeJr? _instance = null;
#nullable restore
        public static SpeciesMimeJr Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesMimeJr();
                }
                return _instance;
            }
        }

		#region SpeciesMime-Jr Constructor
		public SpeciesMimeJr() : base(
			439,
			"Mime-Jr",
			0.6,
			13.0,
			20, // HPs
			25, 45, // Attack & Defense
			70, 90, // Special Attack & Defense
			60		
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
				"Pound",
				"Double-Slap",
				"Headbutt",
				"Psybeam",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Meditate",
				"Mimic",
				"Double-Team",
				"Confuse-Ray",
				"Barrier",
				"Light-Screen",
				"Reflect",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Charm",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Baton-Pass",
				"Encore",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Future-Sight",
				"Fake-Out",
				"Uproar",
				"Torment",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Role-Play",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Teeter-Dance",
				"Tickle",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Shock-Wave",
				"Wake-Up-Slap",
				"Healing-Wish",
				"Natural-Gift",
				"Fling",
				"Copycat",
				"Drain-Punch",
				"Nasty-Plot",
				"Trick-Room",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Power-Split",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Round",
				"Confide",
				"Infestation",
				"Psychic-Terrain"
			};
		}
		#endregion
	}
	#endregion

	//Mime-Jr PokemonInstance Class
	#region Mime-Jr
	public class MimeJrInstance : PokemonInstance
	{
		#region Mime-Jr Constructors
		/// <summary>
		/// Mime-Jr Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public MimeJrInstance(string nickname, int level)
		: base(
				SpeciesMimeJr.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mime-Jr Builder only waiting for a Level
		/// </summary>
		public MimeJrInstance(int level)
		: base(
				SpeciesMimeJr.Instance, // PokemonInstance Species
				"Mime-Jr", level,
				Psychic.Instance, Fairy.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Mime-Jr Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public MimeJrInstance() : base(
			SpeciesMimeJr.Instance, // PokemonInstance Species
			Psychic.Instance, Fairy.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}