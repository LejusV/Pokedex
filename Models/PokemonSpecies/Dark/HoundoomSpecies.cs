using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Houndoom Species to store common natural stats of all Houndooms
	#region HoundoomSpecies
	public class HoundoomSpecies : PokemonSpecies
	{
#nullable enable
		private static HoundoomSpecies? _instance = null;
#nullable restore
        public static HoundoomSpecies Instance => _instance ?? (_instance = new HoundoomSpecies());

		#region HoundoomSpecies Constructor
		public HoundoomSpecies() : base(
			229,
			"Houndoom",
			Dark.Instance, Fire.Instance,
			1.4,
			35.0,
			new PokemonStats(
				75, // HPs
				90, 50, // Attack & Defense
				110, 80, // Spacial Attack & Defense
				95 // Speed
			)			
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
				"Headbutt",
				"Body-Slam",
				"Double-Edge",
				"Leer",
				"Bite",
				"Roar",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Counter",
				"Strength",
				"Solar-Beam",
				"Toxic",
				"Mimic",
				"Double-Team",
				"Smog",
				"Fire-Blast",
				"Swift",
				"Dream-Eater",
				"Rest",
				"Super-Fang",
				"Substitute",
				"Thief",
				"Nightmare",
				"Snore",
				"Curse",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Iron-Tail",
				"Hidden-Power",
				"Sunny-Day",
				"Crunch",
				"Shadow-Ball",
				"Rock-Smash",
				"Beat-Up",
				"Uproar",
				"Heat-Wave",
				"Torment",
				"Will-O-Wisp",
				"Facade",
				"Taunt",
				"Role-Play",
				"Snatch",
				"Secret-Power",
				"Hyper-Voice",
				"Overheat",
				"Odor-Sleuth",
				"Howl",
				"Natural-Gift",
				"Payback",
				"Embargo",
				"Sucker-Punch",
				"Dark-Pulse",
				"Giga-Impact",
				"Nasty-Plot",
				"Thunder-Fang",
				"Fire-Fang",
				"Captivate",
				"Flame-Charge",
				"Foul-Play",
				"Round",
				"Incinerate",
				"Retaliate",
				"Inferno",
				"Snarl",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}