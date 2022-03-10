using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Piplup Species to store common natural stats of all Piplups
	#region SpeciesPiplup
	public class SpeciesPiplup : PokemonSpecies
	{
#nullable enable
		private static SpeciesPiplup? _instance = null;
#nullable restore
        public static SpeciesPiplup Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesPiplup();
                }
                return _instance;
            }
        }

		#region SpeciesPiplup Constructor
		public SpeciesPiplup() : base(
			"Piplup",
			0.4,
			5.2,
			53, // HPs
			51, 53, // Attack & Defense
			61, 56, // Special Attack & Defense
			40		
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
				"Cut",
				"Headbutt",
				"Fury-Attack",
				"Growl",
				"Supersonic",
				"Mist",
				"Hydro-Pump",
				"Surf",
				"Ice-Beam",
				"Blizzard",
				"Bubble-Beam",
				"Peck",
				"Drill-Peck",
				"Dig",
				"Toxic",
				"Agility",
				"Double-Team",
				"Bide",
				"Waterfall",
				"Bubble",
				"Rest",
				"Substitute",
				"Snore",
				"Flail",
				"Protect",
				"Mud-Slap",
				"Icy-Wind",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Hidden-Power",
				"Rain-Dance",
				"Whirlpool",
				"Hail",
				"Facade",
				"Brick-Break",
				"Yawn",
				"Secret-Power",
				"Dive",
				"Feather-Dance",
				"Mud-Sport",
				"Rock-Tomb",
				"Signal-Beam",
				"Aerial-Ace",
				"Covet",
				"Water-Sport",
				"Water-Pulse",
				"Brine",
				"Natural-Gift",
				"Pluck",
				"Fling",
				"Aqua-Ring",
				"Defog",
				"Captivate",
				"Stealth-Rock",
				"Grass-Knot",
				"Double-Hit",
				"Round",
				"Echoed-Voice",
				"Scald",
				"Quash",
				"Water-Pledge",
				"Work-Up",
				"Confide",
				"Power-Trip"
			};
		}
		#endregion
	}
	#endregion

	//Piplup PokemonInstance Class
	#region Piplup
	public class PiplupInstance : PokemonInstance
	{
		#region Piplup Constructors
		/// <summary>
		/// Piplup Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public PiplupInstance(string nickname, int level)
		: base(
				393,
				SpeciesPiplup.Instance, // Pokemon Species
				nickname, level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Piplup Builder only waiting for a Level
		/// </summary>
		public PiplupInstance(int level)
		: base(
				393,
				SpeciesPiplup.Instance, // PokemonInstance Species
				"Piplup", level,
				Water.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Piplup Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Piplup() : base(
			393,
			SpeciesPiplup.Instance, // PokemonInstance Species
			Water.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}