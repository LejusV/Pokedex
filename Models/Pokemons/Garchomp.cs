using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Garchomp Species to store common natural stats of all Garchomps
	#region SpeciesGarchomp
	public class SpeciesGarchomp : PokemonSpecies
	{
#nullable enable
		private static SpeciesGarchomp? _instance = null;
#nullable restore
        public static SpeciesGarchomp Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesGarchomp();
                }
                return _instance;
            }
        }

		#region SpeciesGarchomp Constructor
		public SpeciesGarchomp() : base(
			"Garchomp",
			1.9,
			95.0,
			108, // HPs
			130, 95, // Attack & Defense
			80, 85, // Special Attack & Defense
			102		
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
				"Swords-Dance",
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Tackle",
				"Take-Down",
				"Roar",
				"Flamethrower",
				"Surf",
				"Hyper-Beam",
				"Strength",
				"Dragon-Rage",
				"Earthquake",
				"Dig",
				"Toxic",
				"Double-Team",
				"Fire-Blast",
				"Swift",
				"Rest",
				"Rock-Slide",
				"Slash",
				"Substitute",
				"Snore",
				"Protect",
				"Mud-Slap",
				"Outrage",
				"Sandstorm",
				"Endure",
				"False-Swipe",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Twister",
				"Rain-Dance",
				"Sunny-Day",
				"Crunch",
				"Rock-Smash",
				"Whirlpool",
				"Facade",
				"Brick-Break",
				"Secret-Power",
				"Rock-Tomb",
				"Sand-Tomb",
				"Aerial-Ace",
				"Dragon-Claw",
				"Natural-Gift",
				"Fling",
				"Poison-Jab",
				"Aqua-Tail",
				"Dragon-Pulse",
				"Dragon-Rush",
				"Earth-Power",
				"Giga-Impact",
				"Shadow-Claw",
				"Fire-Fang",
				"Rock-Climb",
				"Draco-Meteor",
				"Iron-Head",
				"Stone-Edge",
				"Captivate",
				"Stealth-Rock",
				"Hone-Claws",
				"Round",
				"Incinerate",
				"Bulldoze",
				"Dragon-Tail",
				"Dual-Chop",
				"Confide",
				"Brutal-Swing"
			};
		}
		#endregion
	}
	#endregion

	//Garchomp PokemonInstance Class
	#region Garchomp
	public class GarchompInstance : PokemonInstance
	{
		#region Garchomp Constructors
		/// <summary>
		/// Garchomp Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public GarchompInstance(string nickname, int level)
		: base(
				445,
				SpeciesGarchomp.Instance, // Pokemon Species
				nickname, level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Garchomp Builder only waiting for a Level
		/// </summary>
		public GarchompInstance(int level)
		: base(
				445,
				SpeciesGarchomp.Instance, // PokemonInstance Species
				"Garchomp", level,
				Dragon.Instance, Ground.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Garchomp Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Garchomp() : base(
			445,
			SpeciesGarchomp.Instance, // PokemonInstance Species
			Dragon.Instance, Ground.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}