using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Ambipom Species to store common natural stats of all Ambipoms
	#region SpeciesAmbipom
	public class SpeciesAmbipom : PokemonSpecies
	{
#nullable enable
		private static SpeciesAmbipom? _instance = null;
#nullable restore
        public static SpeciesAmbipom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAmbipom();
                }
                return _instance;
            }
        }

		#region SpeciesAmbipom Constructor
		public SpeciesAmbipom() : base(
			"Ambipom",
			1.2,
			20.3,
			75, // HPs
			100, 66, // Attack & Defense
			60, 66, // Special Attack & Defense
			115		
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
				"Scratch",
				"Cut",
				"Sand-Attack",
				"Headbutt",
				"Tail-Whip",
				"Hyper-Beam",
				"Low-Kick",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Screech",
				"Double-Team",
				"Swift",
				"Dream-Eater",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Snore",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Baton-Pass",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Role-Play",
				"Brick-Break",
				"Knock-Off",
				"Snatch",
				"Secret-Power",
				"Astonish",
				"Tickle",
				"Aerial-Ace",
				"Bounce",
				"Covet",
				"Shock-Wave",
				"Water-Pulse",
				"Natural-Gift",
				"U-Turn",
				"Payback",
				"Fling",
				"Last-Resort",
				"Seed-Bomb",
				"Giga-Impact",
				"Nasty-Plot",
				"Shadow-Claw",
				"Gunk-Shot",
				"Captivate",
				"Grass-Knot",
				"Double-Hit",
				"Hone-Claws",
				"Low-Sweep",
				"Foul-Play",
				"Round",
				"Acrobatics",
				"Retaliate",
				"Work-Up",
				"Dual-Chop",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Ambipom PokemonInstance Class
	#region Ambipom
	public class AmbipomInstance : PokemonInstance
	{
		#region Ambipom Constructors
		/// <summary>
		/// Ambipom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AmbipomInstance(string nickname, int level)
		: base(
				424,
				SpeciesAmbipom.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ambipom Builder only waiting for a Level
		/// </summary>
		public AmbipomInstance(int level)
		: base(
				424,
				SpeciesAmbipom.Instance, // PokemonInstance Species
				"Ambipom", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Ambipom Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Ambipom() : base(
			424,
			SpeciesAmbipom.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}