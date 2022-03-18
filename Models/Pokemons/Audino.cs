using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Audino Species to store common natural stats of all Audinos
	#region SpeciesAudino
	public class SpeciesAudino : PokemonSpecies
	{
#nullable enable
		private static SpeciesAudino? _instance = null;
#nullable restore
        public static SpeciesAudino Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAudino();
                }
                return _instance;
            }
        }

		#region SpeciesAudino Constructor
		public SpeciesAudino() : base(
			531,
			"Audino",
			1.1,
			31.0,
			103, // HPs
			60, 86, // Attack & Defense
			60, 86, // Special Attack & Defense
			50		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Flamethrower",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Hyper-Beam",
				"Low-Kick",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Fire-Blast",
				"Amnesia",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Substitute",
				"Snore",
				"Protect",
				"Sweet-Kiss",
				"Icy-Wind",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Heal-Bell",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Encore",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Helping-Hand",
				"Role-Play",
				"Wish",
				"Magic-Coat",
				"Yawn",
				"Knock-Off",
				"Skill-Swap",
				"Refresh",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Signal-Beam",
				"Covet",
				"Calm-Mind",
				"Gravity",
				"Healing-Wish",
				"Fling",
				"Lucky-Chant",
				"Last-Resort",
				"Drain-Punch",
				"Zen-Headbutt",
				"Trick-Room",
				"Grass-Knot",
				"Charge-Beam",
				"Psyshock",
				"Telekinesis",
				"Simple-Beam",
				"Entrainment",
				"After-You",
				"Round",
				"Echoed-Voice",
				"Heal-Pulse",
				"Incinerate",
				"Retaliate",
				"Bestow",
				"Work-Up",
				"Wild-Charge",
				"Disarming-Voice",
				"Draining-Kiss",
				"Misty-Terrain",
				"Play-Nice",
				"Confide",
				"Dazzling-Gleam",
				"Baby-Doll-Eyes",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Audino PokemonInstance Class
	#region Audino
	public class AudinoInstance : PokemonInstance
	{
		#region Audino Constructors
		/// <summary>
		/// Audino Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AudinoInstance(string nickname, int level)
		: base(
				SpeciesAudino.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Audino Builder only waiting for a Level
		/// </summary>
		public AudinoInstance(int level)
		: base(
				SpeciesAudino.Instance, // PokemonInstance Species
				"Audino", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Audino Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public AudinoInstance() : base(
			SpeciesAudino.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}