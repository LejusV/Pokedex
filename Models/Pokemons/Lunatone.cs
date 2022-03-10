using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Lunatone Species to store common natural stats of all Lunatones
	#region SpeciesLunatone
	public class SpeciesLunatone : PokemonSpecies
	{
#nullable enable
		private static SpeciesLunatone? _instance = null;
#nullable restore
        public static SpeciesLunatone Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesLunatone();
                }
                return _instance;
            }
        }

		#region SpeciesLunatone Constructor
		public SpeciesLunatone() : base(
			"Lunatone",
			1.0,
			168.0,
			90, // HPs
			55, 65, // Attack & Defense
			95, 85, // Special Attack & Defense
			70		
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
				"Tackle",
				"Body-Slam",
				"Double-Edge",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Rock-Throw",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Hypnosis",
				"Mimic",
				"Double-Team",
				"Harden",
				"Defense-Curl",
				"Light-Screen",
				"Reflect",
				"Self-Destruct",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Psywave",
				"Explosion",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Icy-Wind",
				"Sandstorm",
				"Endure",
				"Rollout",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Psych-Up",
				"Ancient-Power",
				"Shadow-Ball",
				"Future-Sight",
				"Facade",
				"Helping-Hand",
				"Magic-Coat",
				"Recycle",
				"Skill-Swap",
				"Secret-Power",
				"Rock-Tomb",
				"Cosmic-Power",
				"Signal-Beam",
				"Calm-Mind",
				"Gravity",
				"Gyro-Ball",
				"Natural-Gift",
				"Embargo",
				"Heal-Block",
				"Rock-Polish",
				"Power-Gem",
				"Earth-Power",
				"Giga-Impact",
				"Zen-Headbutt",
				"Trick-Room",
				"Iron-Head",
				"Stone-Edge",
				"Stealth-Rock",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Smack-Down",
				"Round",
				"Acrobatics",
				"Bulldoze",
				"Moonblast",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Lunatone PokemonInstance Class
	#region Lunatone
	public class LunatoneInstance : PokemonInstance
	{
		#region Lunatone Constructors
		/// <summary>
		/// Lunatone Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public LunatoneInstance(string nickname, int level)
		: base(
				337,
				SpeciesLunatone.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lunatone Builder only waiting for a Level
		/// </summary>
		public LunatoneInstance(int level)
		: base(
				337,
				SpeciesLunatone.Instance, // PokemonInstance Species
				"Lunatone", level,
				Rock.Instance, Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Lunatone Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Lunatone() : base(
			337,
			SpeciesLunatone.Instance, // PokemonInstance Species
			Rock.Instance, Psychic.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}