using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Archen Species to store common natural stats of all Archens
	#region SpeciesArchen
	public class SpeciesArchen : PokemonSpecies
	{
#nullable enable
		private static SpeciesArchen? _instance = null;
#nullable restore
        public static SpeciesArchen Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesArchen();
                }
                return _instance;
            }
        }

		#region SpeciesArchen Constructor
		public SpeciesArchen() : base(
			566,
			"Archen",
			0.5,
			9.5,
			55, // HPs
			112, 45, // Attack & Defense
			74, 45, // Special Attack & Defense
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
				"Cut",
				"Wing-Attack",
				"Thrash",
				"Leer",
				"Bite",
				"Roar",
				"Rock-Throw",
				"Earthquake",
				"Dig",
				"Toxic",
				"Agility",
				"Quick-Attack",
				"Double-Team",
				"Rest",
				"Rock-Slide",
				"Substitute",
				"Snore",
				"Protect",
				"Scary-Face",
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
				"Earth-Power",
				"Switcheroo",
				"Shadow-Claw",
				"Zen-Headbutt",
				"Defog",
				"Stone-Edge",
				"Stealth-Rock",
				"Head-Smash",
				"Hone-Claws",
				"Smack-Down",
				"Round",
				"Quick-Guard",
				"Ally-Switch",
				"Acrobatics",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Archen PokemonInstance Class
	#region Archen
	public class ArchenInstance : PokemonInstance
	{
		#region Archen Constructors
		/// <summary>
		/// Archen Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public ArchenInstance(string nickname, int level)
		: base(
				SpeciesArchen.Instance, // Pokemon Species
				nickname, level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Archen Builder only waiting for a Level
		/// </summary>
		public ArchenInstance(int level)
		: base(
				SpeciesArchen.Instance, // PokemonInstance Species
				"Archen", level,
				Rock.Instance, Flying.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Archen Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public ArchenInstance() : base(
			SpeciesArchen.Instance, // PokemonInstance Species
			Rock.Instance, Flying.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}