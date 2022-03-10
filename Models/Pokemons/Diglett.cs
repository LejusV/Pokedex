using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Diglett Species to store common natural stats of all Digletts
	#region SpeciesDiglett
	public class SpeciesDiglett : PokemonSpecies
	{
#nullable enable
		private static SpeciesDiglett? _instance = null;
#nullable restore
        public static SpeciesDiglett Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDiglett();
                }
                return _instance;
            }
        }

		#region SpeciesDiglett Constructor
		public SpeciesDiglett() : base(
			"Diglett",
			0.2,
			0.8,
			10, // HPs
			55, 25, // Attack & Defense
			35, 45, // Special Attack & Defense
			95		
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
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Screech",
				"Double-Team",
				"Bide",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Reversal",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Sandstorm",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Magnitude",
				"Pursuit",
				"Hidden-Power",
				"Sunny-Day",
				"Ancient-Power",
				"Rock-Smash",
				"Beat-Up",
				"Uproar",
				"Memento",
				"Facade",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Aerial-Ace",
				"Natural-Gift",
				"Sucker-Punch",
				"Earth-Power",
				"Shadow-Claw",
				"Mud-Bomb",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Echoed-Voice",
				"Final-Gambit",
				"Bulldoze",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Diglett PokemonInstance Class
	#region Diglett
	public class DiglettInstance : PokemonInstance
	{
		#region Diglett Constructors
		/// <summary>
		/// Diglett Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DiglettInstance(string nickname, int level)
		: base(
				50,
				SpeciesDiglett.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diglett Builder only waiting for a Level
		/// </summary>
		public DiglettInstance(int level)
		: base(
				50,
				SpeciesDiglett.Instance, // PokemonInstance Species
				"Diglett", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Diglett Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Diglett() : base(
			50,
			SpeciesDiglett.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}