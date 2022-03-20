using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Houndour Species to store common natural stats of all Houndours
	#region HoundourSpecies
	public class HoundourSpecies : PokemonSpecies
	{
#nullable enable
		private static HoundourSpecies? _instance = null;
#nullable restore
        public static HoundourSpecies Instance => _instance ?? (_instance = new HoundourSpecies());

		#region HoundourSpecies Constructor
		public HoundourSpecies() : base(
			228,
			"Houndour",
			Dark.Instance, Fire.Instance,
			0.6,
			10.8,
			new PokemonStats(
				45, // HPs
				60, 30, // Attack & Defense
				80, 50, // Spacial Attack & Defense
				65 // Speed
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
				"Counter",
				"Solar-Beam",
				"Fire-Spin",
				"Toxic",
				"Rage",
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
				"Reversal",
				"Spite",
				"Protect",
				"Feint-Attack",
				"Sludge-Bomb",
				"Mud-Slap",
				"Destiny-Bond",
				"Detect",
				"Endure",
				"Swagger",
				"Attract",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Pursuit",
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
				"Feint",
				"Payback",
				"Embargo",
				"Punishment",
				"Sucker-Punch",
				"Dark-Pulse",
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