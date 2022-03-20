using System.Collections.Generic;
using Pokedex.Models.PokemonTypes;
using Pokedex.Models.Moves;

namespace Pokedex.Models.Pokemons.Species
{
	//Volcarona Species to store common natural stats of all Volcaronas
	#region VolcaronaSpecies
	public class VolcaronaSpecies : PokemonSpecies
	{
#nullable enable
		private static VolcaronaSpecies? _instance = null;
#nullable restore
        public static VolcaronaSpecies Instance => _instance ?? (_instance = new VolcaronaSpecies());

		#region VolcaronaSpecies Constructor
		public VolcaronaSpecies() : base(
			637,
			"Volcarona",
			Bug.Instance, Fire.Instance,
			1.6,
			46.0,
			new PokemonStats(
				85, // HPs
				60, 65, // Attack & Defense
				135, 105, // Spacial Attack & Defense
				100 // Speed
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
				"Gust",
				"Whirlwind",
				"Fly",
				"Thrash",
				"Ember",
				"Flamethrower",
				"Hyper-Beam",
				"Absorb",
				"Solar-Beam",
				"String-Shot",
				"Fire-Spin",
				"Toxic",
				"Psychic",
				"Double-Team",
				"Light-Screen",
				"Fire-Blast",
				"Amnesia",
				"Leech-Life",
				"Rest",
				"Substitute",
				"Flame-Wheel",
				"Snore",
				"Protect",
				"Giga-Drain",
				"Swagger",
				"Sleep-Talk",
				"Return",
				"Frustration",
				"Safeguard",
				"Hidden-Power",
				"Sunny-Day",
				"Heat-Wave",
				"Will-O-Wisp",
				"Facade",
				"Secret-Power",
				"Overheat",
				"Silver-Wind",
				"Signal-Beam",
				"Aerial-Ace",
				"Calm-Mind",
				"Roost",
				"Tailwind",
				"U-Turn",
				"Magnet-Rise",
				"Flare-Blitz",
				"Poison-Jab",
				"Bug-Buzz",
				"Giga-Impact",
				"Zen-Headbutt",
				"Bug-Bite",
				"Rage-Powder",
				"Quiver-Dance",
				"Flame-Charge",
				"Round",
				"Incinerate",
				"Acrobatics",
				"Struggle-Bug",
				"Wild-Charge",
				"Hurricane",
				"Fiery-Dance",
				"Confide"
			};
		}
		#endregion
	}
	#endregion
}