using Pokedex.Models;
using Pokedex.Models.Types;

namespace Pokedex.Models.Pokemons
{
	//Deoxys-Normal Specie to store common natural stats of every {'abilities': ['pressure'], 'base_experience': 270, 'height': 17, 'id': 386, 'moves': ['fire-punch', 'ice-punch', 'thunder-punch', 'cut', 'bind', 'headbutt', 'body-slam', 'wrap', 'double-edge', 'leer', 'ice-beam', 'hyper-beam', 'low-kick', 'seismic-toss', 'strength', 'solar-beam', 'thunderbolt', 'thunder-wave', 'thunder', 'toxic', 'psychic', 'teleport', 'night-shade', 'mimic', 'double-team', 'recover', 'light-screen', 'reflect', 'swift', 'dream-eater', 'flash', 'rest', 'rock-slide', 'substitute', 'nightmare', 'snore', 'protect', 'mud-slap', 'icy-wind', 'endure', 'swagger', 'sleep-talk', 'return', 'frustration', 'safeguard', 'pursuit', 'hidden-power', 'rain-dance', 'sunny-day', 'psych-up', 'shadow-ball', 'rock-smash', 'torment', 'facade', 'focus-punch', 'taunt', 'trick', 'role-play', 'magic-coat', 'recycle', 'brick-break', 'knock-off', 'skill-swap', 'snatch', 'secret-power', 'rock-tomb', 'cosmic-power', 'signal-beam', 'aerial-ace', 'calm-mind', 'shock-wave', 'water-pulse', 'psycho-boost', 'gravity', 'natural-gift', 'fling', 'psycho-shift', 'poison-jab', 'dark-pulse', 'drain-punch', 'focus-blast', 'energy-ball', 'giga-impact', 'avalanche', 'zen-headbutt', 'flash-cannon', 'trick-room', 'stealth-rock', 'grass-knot', 'charge-beam', 'wonder-room', 'psyshock', 'telekinesis', 'low-sweep', 'round', 'ally-switch', 'confide', 'power-up-punch', 'brutal-swing'], 'name': 'deoxys-normal', 'stats': {'hp': 50, 'attack': 150, 'defense': 50, 'special-attack': 150, 'special-defense': 50, 'speed': 150}, 'types': ['psychic'], 'weight': 608, 'is_baby': False, 'is_legendary': False, 'is_mythical': True, 'hatch_counter': 120, 'gender_rate': -1, 'capture_rate': 3, 'color': 'red', 'shape': 'humanoid', 'habitat': 'rare', 'generation': 'generation-iii', 'growth_rate': 'slow', 'egg_groups': ['no-eggs'], 'names': {'ja-Hrkt': 'デオキシス', 'roomaji': 'Deoxys', 'ko': '테오키스', 'zh-Hant': '代歐奇希斯', 'fr': 'Deoxys', 'de': 'Deoxys', 'es': 'Deoxys', 'it': 'Deoxys', 'en': 'Deoxys', 'ja': 'デオキシス', 'zh-Hans': '代欧奇希斯'}, 'genera': {'ja-Hrkt': 'ＤＮＡポケモン', 'ko': 'DNA포켓몬', 'zh-Hant': 'ＤＮＡ寶可夢', 'fr': 'Pokémon ADN', 'de': 'DNS', 'es': 'Pokémon ADN', 'it': 'Pokémon DNA', 'en': 'DNA Pokémon', 'ja': 'ＤＮＡポケモン', 'zh-Hans': 'ＤＮＡ宝可梦'}}
	public class SpecieDeoxysNormal : PokemonSpecie
	{
#nullable enable
		private static SpecieDeoxysNormal? _instance = null;
#nullable restore
        public static SpecieDeoxysNormal Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new SpecieDeoxysNormal();
                }
                return _instance;
            }
        }

		public SpecieDeoxysNormal() : base(
			"Deoxys-Normal",
			50, // HPs
			150, 50, // Attack & Defense
			150, 50, // Special Attack & Defense
			150			
		) {}
	}


	//Deoxys-Normal Pokemon Class
	public class DeoxysNormal : Pokemon
	{

		public DeoxysNormal(string nickname, int level)
		: base(
				386,
				SpecieDeoxysNormal.Instance, // Pokemon Specie
				nickname, level,
				Psychic.Instance			
		)
		{
			CalculateStats();
			ResetCurrentStats();
		}

		public DeoxysNormal() : base(
			386,
			SpecieDeoxysNormal.Instance, // Pokemon Specie
			Psychic.Instance			
		) {}
	}
}