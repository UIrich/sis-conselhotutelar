﻿using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using DAL;
using model;

public class AtendimentoDAL
{
    ConexaoDB mConn = new ConexaoDB();

    public bool InserirAtendimento(Atendimento atendimento)
    {
        bool sucesso = false;

        using (MySqlConnection conn = mConn.AbrirConexao())
        {
            string query = @"INSERT INTO tb_atendimentos 
                            (Codigo, DataAtendimento, StatusAtendimento, IdCliente, IdAtendente) 
                            VALUES (@Codigo, @DataAtendimento, @StatusAtendimento, @IdCliente, @IdAtendente)";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Codigo", atendimento.CodigoAtendimento);
                cmd.Parameters.AddWithValue("@DataAtendimento", atendimento.DataAtendimento);
                cmd.Parameters.AddWithValue("@StatusAtendimento", atendimento.StatusAtendimento);
                cmd.Parameters.AddWithValue("@IdCliente", atendimento.IdCliente.HasValue ? (object)atendimento.IdCliente.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@IdAtendente", atendimento.IdAtendente.HasValue ? (object)atendimento.IdAtendente.Value : DBNull.Value);

                int result = cmd.ExecuteNonQuery();
                sucesso = result > 0;
            }

            conn.Close();
        }

        return sucesso;
    }

    public List<string> ObterNomesClientes()
    {
        List<string> nomes = new List<string>();

        using (MySqlConnection conn = mConn.AbrirConexao())
        {
            string query = "SELECT Nome FROM tb_clientes";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nomes.Add(reader["Nome"].ToString());
                    }
                }
            }

            conn.Close();
        }

        return nomes;
    }

    public List<string> ObterNomesColaboradores()
    {
        List<string> nomes = new List<string>();

        using (MySqlConnection conn = mConn.AbrirConexao())
        {
            string query = "SELECT Nome FROM tb_colaborador";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        nomes.Add(reader["Nome"].ToString());
                    }
                }
            }

            conn.Close();
        }

        return nomes;
    }

    public int ObterIdClientePorNome(string nomeCliente)
    {
        int idCliente = 0;

        using (MySqlConnection conn = mConn.AbrirConexao())
        {
            string query = "SELECT Id FROM tb_clientes WHERE Nome = @Nome";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Nome", nomeCliente);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idCliente = Convert.ToInt32(reader["Id"]);
                    }
                }
            }

            conn.Close();
        }

        return idCliente;
    }

    public int ObterIdColaboradorPorNome(string nomeColaborador)
    {
        int idColaborador = 0;

        using (MySqlConnection conn = mConn.AbrirConexao())
        {
            string query = "SELECT Id FROM tb_colaborador WHERE Nome = @Nome";
            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@Nome", nomeColaborador);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idColaborador = Convert.ToInt32(reader["Id"]);
                    }
                }
            }

            conn.Close();
        }

        return idColaborador;
    }


    public List<Atendimento> ObterAtendimentosPorColaborador(int idColaborador)
    {
        List<Atendimento> atendimentos = new List<Atendimento>();

        using (MySqlConnection connection = mConn.AbrirConexao())
        {
            string query = "SELECT * FROM tb_atendimentos WHERE IdAtendente = @idColaborador";
            MySqlCommand command = new MySqlCommand(query, connection);
            command.Parameters.AddWithValue("@idColaborador", idColaborador);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Atendimento atendimento = new Atendimento
                    {
                        IdAtendimento = Convert.ToInt32(reader["Id"]),
                        CodigoAtendimento = reader["Codigo"].ToString(),
                        DataAtendimento = Convert.ToDateTime(reader["DataAtendimento"]),
                        StatusAtendimento = reader["StatusAtendimento"].ToString(),
                        IdCliente = reader["IdCliente"] != DBNull.Value ? Convert.ToInt32(reader["IdCliente"]) : (int?)null,
                        IdAtendente = Convert.ToInt32(reader["IdAtendente"])
                    };
                    atendimentos.Add(atendimento);
                }
            }
        }

        return atendimentos;
    }
}
