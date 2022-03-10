using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Archeops Species to store common natural stats of all Archeopss
	#region SpeciesArcheops
	public class SpeciesArcheops : PokemonSpecies
	{
#nullable enable
		private static SpeciesArcheops? _instance = null;
#nullable restore
        public static SpeciesArcheops Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesArcheops();
                }
                return _instance;
            }
        }

		#region SpeciesArcheops Constructor
		public SpeciesArcheops() : base(
			"Archeops",
			1.4,
			32.0,
			75, // HPs
			140, 65, // Attack & Defense
			112, 65, // Special Attack & Defense
			110		
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
				"Wing-Attack",
				"Fly",
				"Thrash",
				"Leer",
				"Roar",
				"Hyper-Beam",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Sky-Attack",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
				"Outrage",
				"Sandstorm",
				"Swagger",
				"Steel-Wing",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dragon-Breath",
				"Iron-Tail",
				"Hidden-Power",
				"Crunch",
				"Ancient-Power",
				"Rock-Smash",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Facade",
				"Taunt",
				"Knock-Off",
				"Endeavor",
				"Secret-Power",
				"Rock-Tomb",
				"Aerial-Ace",
				"Iron-Defense",
				"Dragon-Claw",
				"Bounce",
				"Roost",
				"Pluck",
				"Tailwind",
				"U-Turn",
				"Rock-Polish",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Focus-Blast",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Stone-Edge",
				"Stealth-Rock",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Quick-Guard",
				"Acrobatics",
				"Bulldoze",
				"Dragon-Tail",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Archeops PokemonInstance Class
	#region Archeops
	public class ArcheopsInstance : PokemonInstance
	{
		#region Archeops Constructors
		/// <summary>
		/// Archeops Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ArcheopsInstance(string nickname, int level)
		: base(
				567,
				SpeciesArcheops.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Archeops Builder only waiting for a Level
		/// </summary>
		public ArcheopsInstance(int level)
		: base(
				567,
				SpeciesArcheops.Instance, // PokemonInstance Species
				"Archeops", level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Archeops Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Archeops() : base(
			567,
			SpeciesArcheops.Instance, // PokemonInstance Species
			Rock.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}