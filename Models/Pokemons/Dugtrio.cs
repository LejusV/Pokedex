using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Dugtrio Species to store common natural stats of all Dugtrios
	#region SpeciesDugtrio
	public class SpeciesDugtrio : PokemonSpecies
	{
#nullable enable
		private static SpeciesDugtrio? _instance = null;
#nullable restore
        public static SpeciesDugtrio Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesDugtrio();
                }
                return _instance;
            }
        }

		#region SpeciesDugtrio Constructor
		public SpeciesDugtrio() : base(
			51,
			"Dugtrio",
			0.7,
			33.3,
			35, // HPs
			100, 50, // Attack & Defense
			50, 70, // Special Attack & Defense
			120		
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
				"Body-Slam",
				"Take-Down",
				"Double-Edge",
				"Growl",
				"Hyper-Beam",
				"Earthquake",
				"Fissure",
				"Dig",
				"Toxic",
				"Rage",
				"Mimic",
				"Double-Team",
				"Bide",
				"Fury-Swipes",
				"Rest",
				"Rock-Slide",
				"Tri-Attack",
				"Slash",
				"Substitute",
				"Thief",
				"Snore",
				"Curse",
				"Protect",
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
				"Hidden-Power",
				"Sunny-Day",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Secret-Power",
				"Astonish",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Natural-Gift",
				"Sucker-Punch",
				"Night-Slash",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Mud-Bomb",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Sludge-Wave",
				"Round",
				"Echoed-Voice",
				"Bulldoze",
				"Rototiller",
				"Confide"
			};
		}
		#endregion
	}
	#endregion

	//Dugtrio PokemonInstance Class
	#region Dugtrio
	public class DugtrioInstance : PokemonInstance
	{
		#region Dugtrio Constructors
		/// <summary>
		/// Dugtrio Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public DugtrioInstance(string nickname, int level)
		: base(
				SpeciesDugtrio.Instance, // Pokemon Species
				nickname, level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dugtrio Builder only waiting for a Level
		/// </summary>
		public DugtrioInstance(int level)
		: base(
				SpeciesDugtrio.Instance, // PokemonInstance Species
				"Dugtrio", level,
				Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Dugtrio Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public DugtrioInstance() : base(
			SpeciesDugtrio.Instance, // PokemonInstance Species
			Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}