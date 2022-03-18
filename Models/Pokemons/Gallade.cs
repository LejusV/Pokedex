using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Gallade Species to store common natural stats of all Gallades
	#region SpeciesGallade
	public class SpeciesGallade : PokemonSpecies
	{
#nullable enable
		private static SpeciesGallade? _instance = null;
#nullable restore
        public static SpeciesGallade Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGallade();
                }
                return _instance;
            }
        }

		#region SpeciesGallade Constructor
		public SpeciesGallade() : base(
			475,
			"Gallade",
			1.6,
			52.0,
			68, // HPs
			125, 65, // Attack & Defense
			65, 115, // Special Attack & Defense
			80		
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
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Swords-Dance",
				"Cut",
				"Headbutt",
				"Leer",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Thunderbolt",
				"Thunder-Wave",
				"Earthquake",
				"Toxic",
				"Confusion",
				"Psychic",
				"Teleport",
				"Double-Team",
				"Light-Screen",
				"Reflect",
				"Swift",
				"Dream-Eater",
				"Flash",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Pain-Split",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Psych-Up",
				"Shadow-Ball",
				"Rock-Smash",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Helping-Hand",
				"Trick",
				"Magic-Coat",
				"Recycle",
				"Brick-Break",
				"Knock-Off",
				"Skill-Swap",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Rock-Tomb",
				"Signal-Beam",
				"Aerial-Ace",
				"Bulk-Up",
				"Calm-Mind",
				"Leaf-Blade",
				"Shock-Wave",
				"Natural-Gift",
				"Feint",
				"Close-Combat",
				"Fling",
				"Poison-Jab",
				"Night-Slash",
				"X-Scissor",
				"Drain-Punch",
				"Vacuum-Wave",
				"Focus-Blast",
				"Giga-Impact",
				"Psycho-Cut",
				"Zen-Headbutt",
				"Trick-Room",
				"Stone-Edge",
				"Captivate",
				"Grass-Knot",
				"Charge-Beam",
				"Wide-Guard",
				"Wonder-Room",
				"Psyshock",
				"Telekinesis",
				"Magic-Room",
				"Low-Sweep",
				"Round",
				"Echoed-Voice",
				"Stored-Power",
				"Quick-Guard",
				"Ally-Switch",
				"Heal-Pulse",
				"Retaliate",
				"Bulldoze",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Dazzling-Gleam",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Gallade PokemonInstance Class
	#region Gallade
	public class GalladeInstance : PokemonInstance
	{
		#region Gallade Constructors
		/// <summary>
		/// Gallade Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GalladeInstance(string nickname, int level)
		: base(
				SpeciesGallade.Instance, // Pokemon Species
				nickname, level,
				Psychic.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gallade Builder only waiting for a Level
		/// </summary>
		public GalladeInstance(int level)
		: base(
				SpeciesGallade.Instance, // PokemonInstance Species
				"Gallade", level,
				Psychic.Instance, Fighting.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Gallade Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public GalladeInstance() : base(
			SpeciesGallade.Instance, // PokemonInstance Species
			Psychic.Instance, Fighting.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}