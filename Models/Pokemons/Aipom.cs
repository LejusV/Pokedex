using System.Collections.Generic;
using Pokedex.Models;
using Pokedex.Models.PokeTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons
{
	//Aipom Species to store common natural stats of all Aipoms
	#region SpeciesAipom
	public class SpeciesAipom : PokemonSpecies
	{
#nullable enable
		private static SpeciesAipom? _instance = null;
#nullable restore
        public static SpeciesAipom Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpeciesAipom();
                }
                return _instance;
            }
        }

		#region SpeciesAipom Constructor
		public SpeciesAipom() : base(
			"Aipom",
			0.8,
			11.5,
			55, // HPs
			70, 55, // Attack & Defense
			40, 55, // Special Attack & Defense
			85		
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
				"Double-Slap",
				"Mega-Punch",
				"Fire-Punch",
				"Ice-Punch",
				"Thunder-Punch",
				"Scratch",
				"Cut",
				"Slam",
				"Mega-Kick",
				"Sand-Attack",
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Tail-Whip",
				"Low-Kick",
				"Counter",
				"Seismic-Toss",
				"Strength",
				"Solar-Beam",
				"Thunderbolt",
				"Thunder-Wave",
				"Thunder",
				"Dig",
				"Toxic",
				"Agility",
				"Mimic",
				"Screech",
				"Double-Team",
				"Defense-Curl",
				"Metronome",
				"Swift",
				"Dream-Eater",
				"Fury-Swipes",
				"Rest",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Mud-Slap",
				"Zap-Cannon",
				"Detect",
				"Endure",
				"Swagger",
				"Fury-Cutter",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Dynamic-Punch",
				"Baton-Pass",
				"Pursuit",
				"Iron-Tail",
				"Hidden-Power",
				"Rain-Dance",
				"Sunny-Day",
				"Shadow-Ball",
				"Rock-Smash",
				"Beat-Up",
				"Fake-Out",
				"Uproar",
				"Facade",
				"Focus-Punch",
				"Taunt",
				"Role-Play",
				"Revenge",
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
				"Switcheroo",
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
				"Quick-Guard",
				"Acrobatics",
				"Retaliate",
				"Work-Up",
				"Tail-Slap",
				"Confide",
				"Power-Up-Punch"
			};
		}
		#endregion
	}
	#endregion

	//Aipom PokemonInstance Class
	#region Aipom
	public class AipomInstance : PokemonInstance
	{
		#region Aipom Constructors
		/// <summary>
		/// Aipom Instance Constructor waiting for a Nickname & a Level
		/// </summary>
		public AipomInstance(string nickname, int level)
		: base(
				190,
				SpeciesAipom.Instance, // Pokemon Species
				nickname, level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aipom Builder only waiting for a Level
		/// </summary>
		public AipomInstance(int level)
		: base(
				190,
				SpeciesAipom.Instance, // PokemonInstance Species
				"Aipom", level,
				Normal.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		/// <summary>
		/// Aipom Builder waiting for no params (Building a Wiki PokemonInstance without personal stats nor any level)
		/// </summary>
		/*
		public Aipom() : base(
			190,
			SpeciesAipom.Instance, // PokemonInstance Species
			Normal.Instance			
		) {}
		*/
		#endregion
	}
	#endregion
}